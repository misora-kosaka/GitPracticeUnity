# 第9回：git cherry-pick

> **releaseへのbackportをForkで再現**
> [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) の自分のForkでfeature / release branchを作り、特定commitだけを `cherry-pick` する流れを試します。

## feature側で3commit作る

```text
C Add new player movement
D Fix player collision
E Add player dash
```

`D` のSHAを `git log --oneline` で控えます。

## release branchへDだけ持っていく

```bash
git switch -c release/1.0 <feature作成前のcommit>
git cherry-pick <DのSHA>
git log --oneline --graph --decorate --all
```

元Dとrelease側のD'でSHAが異なることを確認します。

## backportの記録

```bash
git cherry-pick -x <DのSHA>
```

## commitをまとめる

```bash
git cherry-pick -n <commit1>
git cherry-pick -n <commit2>
git diff --staged
git commit -m "Backport player fixes"
```

CONFLICTした場合：

```bash
git status
# 修正
git add <file>
git cherry-pick --continue
```

中止：

```bash
git cherry-pick --abort
```
