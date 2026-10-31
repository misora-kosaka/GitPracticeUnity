<img width="1672" height="941" alt="ChatGPT Image 2026年8月11日 22_18_11 (9)" src="https://github.com/user-attachments/assets/05946d9f-3258-4f7d-8555-6b76607e8769" />

# 第5回：rebase CONFLICT

> **この回は意図的にCONFLICTを起こします**
> 必ず [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) の自分のForkで練習してください。元リポジトリでは実行しません。

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
