# 第7回：restore / reset / revert / amend

## restore

Player.csを編集し、まだaddせず：

```bash
git diff
git restore Assets/Scripts/Player.cs
```

## restore --staged

```bash
git add Assets/Scripts/Player.cs
git restore --staged Assets/Scripts/Player.cs
```

Working Treeの変更が残ることを確認します。

## amend

1commit作ったあと、別の変更をstageして：

```bash
git commit --amend --no-edit
```

commit SHAが変わることを確認します。

## reset

練習用branchで試してください。

```bash
git reset --soft HEAD~1
git reset HEAD~1
```

`--hard` はWorking Treeの変更も失うため、内容を確認した上でpractice branchだけで試します。

```bash
git reset --hard HEAD~1
```

## revert

```bash
git revert <commit>
```

元commitを消さず、「打ち消す新commit」が増えることを確認します。
