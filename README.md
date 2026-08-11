# GitPracticeUnity

「Unityでいってみよう！」の連載 **Unity開発者のための実践Git講座** 用の練習リポジトリです。

このリポジトリは、記事を読むだけではなく、自分のGitHubアカウントへForkして実際に `branch` / `merge` / `rebase` / `stash` / `cherry-pick` / `reflog` を試すための教材として使います。

## ブログ記事を読みながら一緒に試せます

各記事には、このリポジトリを使った実習を対応させています。

- 教材本体: [misora-kosaka/GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity)
- 初めての方: [第0回：Fork・clone・upstream登録](docs/episodes/00-introduction.md)
- 各回の練習ガイド: [`docs/episodes/`](docs/episodes/)
- ブログ本文へ貼り付ける導線文: [ブログ記事用の案内文](docs/blog-inserts.md)

練習では意図的にCONFLICT、rebase、`reset --hard` などを試します。**元リポジトリではなく、自分のForkで実行してください。**

## まず最初に

1. GitHub上でこのリポジトリを **Fork** します。
2. Forkした自分のリポジトリをcloneします。
3. 元リポジトリを `upstream` として登録します。
4. `docs/episodes/` の各回を順番に試します。

```bash
# YOUR_NAME は自分のGitHubユーザー名

git clone https://github.com/YOUR_NAME/GitPracticeUnity.git
cd GitPracticeUnity

git remote add upstream https://github.com/misora-kosaka/GitPracticeUnity.git

git remote -v
```

> 練習では意図的にCONFLICTや `reset --hard` を発生させます。必ず自分のForkで試してください。

## ベースとなるUnityファイル

```text
Assets/
└── Scripts/
    ├── Player.cs
    ├── Enemy.cs
    ├── GameManager.cs
    └── Inventory.cs
```

記事中の例と同じように、主に `Player.cs` を変更しながらGitの履歴を作ります。

## 全11回

| 回 | テーマ | 練習ガイド |
|---:|---|---|
| 0 | 予告・準備 | [00-introduction.md](docs/episodes/00-introduction.md) |
| 1 | Working Tree / Staging Area / HEAD | [01-working-tree-staging-head.md](docs/episodes/01-working-tree-staging-head.md) |
| 2 | merge / Fast-forward / 3-way | [02-merge.md](docs/episodes/02-merge.md) |
| 3 | Pull Requestの3方式 | [03-pull-request.md](docs/episodes/03-pull-request.md) |
| 4 | rebase | [04-rebase.md](docs/episodes/04-rebase.md) |
| 5 | CONFLICT | [05-conflict.md](docs/episodes/05-conflict.md) |
| 6 | fetch / pull / pull --rebase | [06-fetch-pull.md](docs/episodes/06-fetch-pull.md) |
| 7 | restore / reset / revert / amend | [07-undo.md](docs/episodes/07-undo.md) |
| 8 | stash | [08-stash.md](docs/episodes/08-stash.md) |
| 9 | cherry-pick | [09-cherry-pick.md](docs/episodes/09-cherry-pick.md) |
| 10 | reflog | [10-reflog.md](docs/episodes/10-reflog.md) |
| 11 | UnityチームGit運用 総まとめ | [11-workflow.md](docs/episodes/11-workflow.md) |

## Gitで迷ったら

まずこの2つを確認してください。

```bash
git status
git log --oneline --graph --decorate --all
```

事故ったときは、さらにこれ。

```bash
git reflog
```

## Unityについて

Git操作の練習が主目的なので、サンプルは依存関係を極力減らした小さなC#スクリプトだけにしています。

`ProjectSettings/ProjectVersion.txt` はUnity 6系の目印として入れています。別のUnity 6.xで開いた場合はUnityがProjectSettingsやPackage関連ファイルを更新することがあります。Git練習中に意図しない差分が増えた場合は、まず `git status` で確認してください。

## License

MIT License
