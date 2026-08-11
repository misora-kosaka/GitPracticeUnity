# ブログ記事用：GitPracticeUnityへの案内文

「Unityでいってみよう！」の各記事へ、そのまま貼り付けられる練習リポジトリ案内です。

## 第0回用

### この記事はGitPracticeUnityをForkして一緒に試せます！

今回の実践Git講座では、説明を読むだけじゃなく、実際にGitの履歴を動かして確認できるように練習用リポジトリを用意しました。

**GitPracticeUnity**  
https://github.com/misora-kosaka/GitPracticeUnity

まずGitHubでこのリポジトリをForkしてください。以降の実験は全部、自分のFork側で行います。CONFLICTや `reset --hard` も扱うので、元リポジトリを直接変更しないのが大前提です。

```bash
git clone https://github.com/YOUR_NAME/GitPracticeUnity.git
cd GitPracticeUnity
git remote add upstream https://github.com/misora-kosaka/GitPracticeUnity.git
git remote -v
```

`origin` が自分のFork、`upstream` が教材本体になっていれば準備完了。各回には対応する練習ガイドも用意しています。

---

## 第1回用

### Player.csを実際に変更してみよう！

今回のWorking Tree・Staging Area・HEADは、練習用リポジトリ **GitPracticeUnity** でそのまま試せます。

https://github.com/misora-kosaka/GitPracticeUnity

初めての方は第0回でFork・clone・upstream登録まで済ませてください。練習を独立させたい場合は、教材本体のmainからpractice branchを作って始めると安心です。

```bash
git fetch upstream
git switch -c practice/01-working-tree upstream/main
```

この状態で `Assets/Scripts/Player.cs` の `moveSpeed` を変更して、記事の `status` → `diff` → `add` → `commit` を順番に試してみてください。

---

## 第2回用

### mergeは図を見るだけじゃなく実際に履歴を作ってみよう！

GitPracticeUnityの自分のForkで `practice/merge` やfeature branchを作れば、Fast-forward、`--no-ff`、3-way mergeを実際のGitグラフで比較できます。

練習ガイド：`docs/episodes/02-merge.md`

---

## 第3回用

### Pull Requestの3方式も自分のForkで試せます！

GitPracticeUnityをForkし、自分のFork内で **feature branch → main** のPull Requestを作れば、Merge commit / Squash and merge / Rebase and mergeを安全に比較できます。元リポジトリへPRを送る必要はありません。

練習ガイド：`docs/episodes/03-pull-request.md`

---

## 第4回用

### rebaseは実際にSHAが変わるところまで確認！

GitPracticeUnityの自分のForkでfeature側とmain相当側に別々のcommitを作り、`git rebase` 前後のGitグラフとSHAを比較できます。

練習ガイド：`docs/episodes/04-rebase.md`

---

## 第5回用

### CONFLICTをわざと起こして解決してみよう！

この回はGitPracticeUnityの `Player.cs` を2つのbranchで別々に変更して、意図的にCONFLICTを作れるようにしています。必ず自分のForkで試してください。

練習ガイド：`docs/episodes/05-conflict.md`

---

## 第6回用

### origin/mainが動く瞬間を2つのcloneで確認！

GitPracticeUnityの同じForkを2つのフォルダへcloneすると、「自分」と「チームメンバー役」を1人で再現できます。片方からpushして、もう片方で `git fetch` したときにlocal mainと `origin/main` がどう変わるか確認してみてください。

練習ガイド：`docs/episodes/06-fetch-pull.md`

---

## 第7回用

### restore・reset・revert・amendをpractice branchで試そう！

今回の取り消し操作もGitPracticeUnityで実際に確認できます。特に `reset --hard` はWorking Treeまで変更するので、必ず自分のForkの練習用branchで試してください。

練習ガイド：`docs/episodes/07-undo.md`

---

## 第8回用

### Unityらしく新規ファイルと.metaもstashしてみよう！

GitPracticeUnityではtrackedな `Player.cs` の変更だけでなく、新規Asset相当のファイルと `.meta` を作って、通常のstashと `git stash -u` の違いも再現できます。

練習ガイド：`docs/episodes/08-stash.md`

---

## 第9回用

### featureからreleaseへ「このcommitだけ」を持っていこう！

GitPracticeUnityの自分のForkでfeature branchに複数commitを作り、そのうち1つだけを `release/1.0` へcherry-pickするbackportを試せます。

練習ガイド：`docs/episodes/09-cherry-pick.md`

---

## 第10回用

### reset事故もわざと作れば怖くない！

GitPracticeUnityのpractice branchで複数commitを作り、あえて `git reset --hard HEAD~3` を実行。そのあと `git reflog` から元のcommitを探してrescue branchを作るところまで試せます。

練習ガイド：`docs/episodes/10-reflog.md`

---

## 第11回用

### 最後は全11回を一本のワークフローへ！

GitPracticeUnityを使って、feature開発 → stash → rebase → CONFLICT解決 → Pull Request → releaseへのcherry-pick → reflogによる救出まで、一連のUnityチーム開発として通してみましょう。

練習ガイド：`docs/episodes/11-workflow.md`

---

## 第2〜11回で使える短い共通版

> **この記事はGitPracticeUnityで実際に試せます！**  
> 練習用リポジトリを自分のGitHubアカウントへForkして、記事と同じ操作を手元で再現してみてください。CONFLICTや履歴を書き換える操作もあるので、必ず自分のForkで実行します。  
> https://github.com/misora-kosaka/GitPracticeUnity
