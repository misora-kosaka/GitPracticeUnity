# 練習ガイド

<img width="1536" height="1024" alt="Git×Unity はじめての練習ガイド" src="https://github.com/user-attachments/assets/a2c824b4-1f8c-406e-9c93-9bde149616fb" />

このフォルダは「Unity開発者のための実践Git講座」と対応しています。

各回はできるだけ独立して試せるようにしていますが、Gitの履歴は手元の操作で変わります。記事と完全に同じcommit IDになる必要はありません。

## ブログから来た方へ

この教材は、ブログ[Unityでいってみよう！](https://unityletsgo.hatenablog.com/)の **Unity開発者のための実践Git講座** と同じ題材を使っています。

初めての方は、まず [第0回：準備](episodes/00-introduction.md) で自分のGitHubアカウントへForkしてください。以降は、各記事に対応する `docs/episodes/` のガイドを開いて実際にコマンドを試せます。

<img width="1310" height="1201" alt="ChatGPT Image 2026年8月11日 22_19_12 (4)" src="https://github.com/user-attachments/assets/1f88ad0f-cc58-476d-909e-f197ccef5683" />

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
