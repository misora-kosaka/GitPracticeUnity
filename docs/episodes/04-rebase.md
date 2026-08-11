# 第4回：git rebase

> **Forkで実践**
> [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) の自分のForkを使い、feature側のcommitを別baseへ載せ直す流れを試します。初回セットアップは [第0回](00-introduction.md) を参照してください。

## 目的

feature側のcommitを、進んだmainの後ろへ載せ直します。

```bash
git switch main
git switch -c practice/rebase-main
git switch -c feature/player-rebase
```

feature側でPlayer.csを変更して2commit作ります。

次に `practice/rebase-main` に戻り、GameManager.csなど別ファイルを変更して2commit作ります。

```bash
git switch feature/player-rebase
git log --oneline --graph --decorate --all
git rebase practice/rebase-main
git log --oneline --graph --decorate --all
```

feature側commitのSHAが変わることを確認します。
