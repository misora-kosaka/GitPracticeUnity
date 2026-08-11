# 第10回：git reflog

> **この回は意図的にcommitを見えなくします**
> [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) の自分のForkで、必ずpractice branchを使ってください。`reset --hard` 後に `reflog` からcommitを探し、rescue branchで保護します。

この回は必ずpractice branchで行ってください。

## 1. 3commit以上作る

```bash
git switch -c practice/reflog
```

Player.csなどを少しずつ変更して3commit作ります。

## 2. 意図的に戻しすぎる

```bash
git log --oneline --decorate -5
git reset --hard HEAD~3
```

## 3. reflogで探す

```bash
git reflog
```

reset前のcommitを見つけて：

```bash
git show <old-commit>
```

## 4. まずrescue branch

```bash
git branch rescue/before-reset <old-commit>
git switch rescue/before-reset
```

commitが復旧できたことを確認します。

## ORIG_HEAD

reset直後なら：

```bash
git show ORIG_HEAD
git branch rescue/orig-head ORIG_HEAD
```

> 未commitのWorking Tree変更を `reset --hard` で捨てた場合、その内容はreflogでは基本的に復旧できません。
