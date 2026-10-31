<img width="1672" height="941" alt="ChatGPT Image 2026年8月11日 22_18_11 (5)" src="https://github.com/user-attachments/assets/041105f1-eaa2-4728-9fc4-e8fd2470d4af" />


# 第3回：GitHub Pull Request

> **ForkでPull Requestを試せます**
> [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) をForkし、**自分のFork内のfeature branch → 自分のForkのmain** へPull Requestを作って練習します。元リポジトリへのPRは作らないでください。

## 目的

自分のFork内でfeature branchからmainへのPull Requestを作り、GitHubのmerge方式を確認します。

```bash
git switch main
git switch -c feature/inventory
```

`Inventory.cs` のcapacityを変更し、2〜3個のcommitを作ってpushします。

```bash
git push -u origin feature/inventory
```

GitHub上でPull Requestを作ります。

> Fork元ではなく、自分のForkの `main` をbaseに選んで練習すると安全です。

確認する項目：

- Create a merge commit
- Squash and merge
- Rebase and merge

実際にmerge方式を変えて比較したい場合は、同じ変更を別branchで作り直して試してください。
