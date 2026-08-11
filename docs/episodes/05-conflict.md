# 第5回：rebase CONFLICT

記事と同じ衝突を意図的に作ります。

## Base

`Player.cs` の `moveSpeed` が `5.0f` の状態を起点にします。

## feature側

```bash
git switch -c feature/player-conflict
```

`moveSpeed = 7.0f` に変更してcommit。

## main相当側

起点branchへ戻り、`moveSpeed = 10.0f` に変更してcommit。

## rebase

```bash
git switch feature/player-conflict
git rebase <main相当branch>
```

CONFLICTしたら、

```bash
git status
git rebase --show-current-patch
```

VS Codeなどで最終的なResultを `8.0f` にしてみます。

```bash
git add Assets/Scripts/Player.cs
git rebase --continue
```

最初からやり直す場合：

```bash
git rebase --abort
```
