<img width="1672" height="941" alt="ChatGPT Image 2026年8月11日 22_16_59 (1)" src="https://github.com/user-attachments/assets/5a523926-d183-4365-a0ac-934e3e365c62" />

# 第0回：準備

## このリポジトリをForkして練習しよう

この連載は、[GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) を自分のGitHubアカウントへForkして進めます。元リポジトリは教材の基準状態として残し、CONFLICTや `reset --hard` などの練習は必ず自分のForkで行ってください。

### 1. GitHubでFork

1. [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) を開きます。
2. GitHub右上の **Fork** を選びます。
3. `Owner` に自分のGitHubアカウントを選び、Forkを作成します。
4. 作成された `YOUR_NAME/GitPracticeUnity` を開きます。

### 2. 自分のForkをclone

```bash
git clone https://github.com/YOUR_NAME/GitPracticeUnity.git
cd GitPracticeUnity
```

### 3. 教材本体をupstreamとして登録

```bash
git remote add upstream https://github.com/misora-kosaka/GitPracticeUnity.git
git remote -v
```

表示のイメージ：

```text
origin    https://github.com/YOUR_NAME/GitPracticeUnity.git
upstream  https://github.com/misora-kosaka/GitPracticeUnity.git
```

`origin` は自分のFork、`upstream` は教材本体です。ここまでできれば準備完了です。

## ゴール

Fork → clone → upstream登録までを終え、練習できる状態にします。

最後に現在の状態も確認しておきましょう。

```bash
git status
git log --oneline --graph --decorate --all
```
