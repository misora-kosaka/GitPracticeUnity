# 第11回：総合演習

> **全11回を自分のForkで通してみよう**
> [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) を使い、feature開発 → stash → rebase → Pull Request → cherry-pick → reflogまで、一連のUnityチーム開発をまとめて練習します。

第1〜10回を1本につなげます。

## 1. mainを確認

```bash
git switch main
git fetch origin
git log --oneline --graph --decorate --all
```

## 2. feature作成

```bash
git switch -c feature/player-controller
```

Player.csを変更して複数commitを作ります。

## 3. 緊急作業をstashで退避

```bash
git stash push -u -m "WIP Player Controller"
```

別branchへ移ってhotfix commitを作り、その後featureへ戻してstashを復元します。

## 4. 最新mainへ追従

```bash
git fetch origin
git rebase origin/main
```

CONFLICTが起きたら解決して：

```bash
git add <file>
git rebase --continue
```

## 5. Pull Request

featureをpushし、自分のFork内でmainへのPRを作成します。

```bash
git push -u origin feature/player-controller
```

Merge / Squash / Rebaseの違いを意識して統合方式を選びます。

## 6. releaseへbackport

main上の修正commitから：

```bash
git switch release/1.0
git cherry-pick -x <fix-commit>
```

## 7. 事故復旧

practice branchでreset事故を作り：

```bash
git reflog
git show <commit>
git branch rescue/work <commit>
```

までできれば全11回完走です。
