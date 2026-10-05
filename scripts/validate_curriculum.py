"""Read-only validation. Does not require exercises to remain unimplemented."""
from pathlib import Path
import json
import re

ROOT = Path(__file__).resolve().parents[1]
def load(name):
    return json.loads((ROOT / name).read_text(encoding="utf-8-sig"))
def require(condition, message):
    if not condition:
        raise SystemExit(message)

index = load("curriculum.json")
require([row["day"] for row in index] == list(range(1, 101)), "Index must contain ordered days 1..100.")
folders = list((ROOT / "days").glob("day-*"))
require(len(folders) == 100, "Expected exactly 100 distinct day folders.")
require(len({row["path"] for row in index}) == 100, "Day paths must be distinct.")
total_tests = 0
for row in index:
    folder = ROOT / row["path"]
    require(folder.is_dir() and folder.parent == ROOT / "days", f"Invalid day path: {folder}")
    for name in ("README.md", "Example.cs", "Challenge.cs", "ChallengeTests.cs", "Reflection.md"):
        require((folder / name).is_file(), f"Missing {folder / name}")
    readme = (folder / "README.md").read_text(encoding="utf-8-sig")
    for level in (1, 2, 3):
        require(f"## Exercise {level}" in readme, f"Missing exercise {level}: {folder}")
    namespace = f"namespace Days.Day{row['day']:03d};"
    for name in ("Example.cs", "Challenge.cs", "ChallengeTests.cs"):
        require(namespace in (folder / name).read_text(encoding="utf-8-sig"), f"Wrong namespace: {folder / name}")
    tests = (folder / "ChallengeTests.cs").read_text(encoding="utf-8-sig")
    require(f'[Trait("Day", "{row["day"]:03d}")]' in tests, f"Missing day trait: {folder}")
    count = len(re.findall(r"\[(?:Fact|Theory)(?:\(|\])", tests))
    require(count >= row["suppliedTests"], f"Supplied tests removed: {folder}")
    total_tests += count
    require(row["checkpoint"] == (row["day"] % 10 == 0), f"Wrong checkpoint: {folder}")

progress = load("progress.json")
require(isinstance(progress, dict) and isinstance(progress.get("completedDays"), list), "progress.json needs completedDays array.")
completed = progress["completedDays"]
require(all(type(day) is int and 1 <= day <= 100 for day in completed), "Completed days must be integers 1..100.")
require(len(set(completed)) == len(completed), "Completed days must not contain duplicates.")

for file in ROOT.rglob("*.md"):
    if any(part in {"bin", "obj", ".git", "artifacts"} for part in file.relative_to(ROOT).parts):
        continue
    text = file.read_text(encoding="utf-8-sig")
    for target in re.findall(r"\[[^\]]*\]\(([^)]+)\)", text):
        if re.match(r"^[a-zA-Z]+:", target) or target.startswith("#"):
            continue
        local = target.split("#", 1)[0]
        require((file.parent / local).exists(), f"Broken local link in {file}: {target}")

print(f"Validated 100 days, 300 exercise descriptions, {total_tests} day tests, 10 checkpoints and all local Markdown links.")
print(f"Completed-day declarations: {len(completed)} (evidence review remains learner-owned).")
