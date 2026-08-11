# 第1回：Working Tree / Staging Area / HEAD

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
