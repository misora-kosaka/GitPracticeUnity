# 第2回：git merge

この回ではpractice branchを使います。

```bash
git switch main
git switch -c practice/merge
```

## Fast-forward

```bash
git switch -c feature/player
```

`Player.cs` の `moveSpeed` を変更してcommitします。

```bash
git add Assets/Scripts/Player.cs
git commit -m "Update player movement"

git switch practice/merge
git merge feature/player

git log --oneline --graph --decorate --all
```

`practice/merge` のポインタだけが前へ進むFast-forwardを確認します。

## --no-ff

新しいfeature branchを作り1commit追加したあと、

```bash
git switch practice/merge
git merge --no-ff feature/player-noff
```

merge commitが作られることを確認します。

## 3-way merge

base branchとfeature branchの両方に別commitを追加してからmergeします。

```bash
git log --oneline --graph --decorate --all
```

共通祖先から2本に分岐した履歴がmerge commitへ合流する形を確認してください。
