# 第8回：git stash

## tracked変更を退避

Player.csを編集して：

```bash
git stash push -m "WIP Player Controller"
git status
git stash list
git stash show -p stash@{0}
```

戻す：

```bash
git stash pop
```

## untrackedを含める

Unityで新しいファイルを作る代わりに、練習では以下でもOKです。

```bash
printf "practice" > Assets/PracticeAsset.txt
printf "fileFormatVersion: 2
guid: 0123456789abcdef0123456789abcdef
" > Assets/PracticeAsset.txt.meta

git status
git stash
```

untracked fileが残ることを確認したら、

```bash
git stash push -u -m "WIP untracked asset"
```

でuntrackedも退避されることを確認します。

## applyとpop

```bash
git stash apply stash@{0}
git stash list
git stash drop stash@{0}
```

`apply` はstashを残し、`pop` は成功時に削除する違いを確認します。
