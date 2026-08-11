# 練習ガイド

このフォルダは「Unity開発者のための実践Git講座」と対応しています。

各回はできるだけ独立して試せるようにしていますが、Gitの履歴は手元の操作で変わります。記事と完全に同じcommit IDになる必要はありません。

## ブログから来た方へ

この教材は、ブログ「Unityでいってみよう！」の **Unity開発者のための実践Git講座** と同じ題材を使っています。

初めての方は、まず [第0回：準備](episodes/00-introduction.md) で自分のGitHubアカウントへForkしてください。以降は、各記事に対応する `docs/episodes/` のガイドを開いて実際にコマンドを試せます。

ブログ本文へリポジトリ案内を追加するときは、[ブログ記事用の案内文](blog-inserts.md) に第0回〜第11回の貼り付け用文章を用意しています。

## 共通確認コマンド

```bash
git status
git branch -vv
git log --oneline --graph --decorate --all
```

## 練習するときのおすすめ

- commit messageはガイドと同じにすると履歴を比較しやすいです。
- CONFLICTやresetの練習は必ず自分のForkで行ってください。
- SHAは環境ごとに変わるので、ガイドにある `<commit>` は自分の `git log --oneline` の値へ置き換えます。
