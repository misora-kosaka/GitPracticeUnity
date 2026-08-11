# 練習ガイド

このフォルダは「Unity開発者のための実践Git講座」と対応しています。

各回はできるだけ独立して試せるようにしていますが、Gitの履歴は手元の操作で変わります。記事と完全に同じcommit IDになる必要はありません。

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
