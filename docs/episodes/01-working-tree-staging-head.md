<img width="1672" height="941" alt="ChatGPT Image 2026年8月11日 22_18_11 (1)" src="https://github.com/user-attachments/assets/fed21e2f-7c16-44c5-8db6-7d4ebc2ac166" />

# 第1回：Working Tree / Staging Area / HEAD

> **この回を実際に試せます**
> [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) を自分のGitHubアカウントへForkしてから進めてください。初めての方は [第0回：準備](00-introduction.md) でFork・clone・upstream登録を先に行います。

練習を独立させたい場合は、教材本体の `main` からpractice branchを作ると安全です。

```bash
git fetch upstream
git switch -c practice/01-working-tree upstream/main
```

## 1. Player.csを編集

`Assets/Scripts/Player.cs` の `moveSpeed` を `5.0f` から `7.0f` に変更します。

```bash
git status
git diff
```

## 2. Staging Areaへ

```bash
git add Assets/Scripts/Player.cs
git status
git diff --staged
```

## 3. add後にもう一度編集

`moveSpeed` を `8.0f` に変更して `git status` と以下を比較します。

```bash
git diff
git diff --staged
```

Staging Areaには7.0f、Working Treeには8.0fという「2つの変更」が存在することを確認してください。

## 4. commit

一度7.0fへ戻すか、もう一度addしてからcommitします。

```bash
git add Assets/Scripts/Player.cs
git commit -m "Change player move speed"
git log --oneline --decorate -3
```

`HEAD` が新しいcommitを指すことを確認します。
