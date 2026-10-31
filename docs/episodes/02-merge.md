<img width="1672" height="941" alt="ChatGPT Image 2026年8月11日 22_18_11 (3)" src="https://github.com/user-attachments/assets/e3c932e1-3434-4583-bed9-37708bf0aabe" />


# 第2回：git merge

> **Forkで実践**
> この回は [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) の自分のForkで試せます。未準備の場合は [第0回](00-introduction.md) を先に終えてください。以下のbranch操作はFork内だけで行います。

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
