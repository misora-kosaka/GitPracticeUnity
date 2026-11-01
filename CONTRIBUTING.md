# Practice rules

<img width="1536" height="1024" alt="美空のGit練習ルールボード" src="https://github.com/user-attachments/assets/34930ba9-8ad9-428e-87ce-284ecb0b5628" />

このリポジトリはGit練習用です。

- 練習は必ず自分のForkで行ってください。
- `main` を壊しても学習できますが、元へ戻せるよう `upstream` を登録しておくことを推奨します。
- `git reset --hard`、force push、branch削除は、自分のFork以外では行わないでください。
- Unityが自動生成した意図しない差分は、commit前に `git status` と `git diff` で確認してください。

## 自分のForkのmainを教材の最新状態へ合わせる

作業中の変更を失ってよいことを確認した上で実行してください。

```bash
git switch main
git fetch upstream
git status
```

mainに自分のcommitがない場合はFast-forwardで更新できます。

```bash
git merge --ff-only upstream/main
```

mainを意図的に変更する練習をした場合は、別のpractice branchを作り直すか、Forkを作り直す方法が最も分かりやすいです。
