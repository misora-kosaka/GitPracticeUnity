# 第0回：準備

## ゴール

Fork → clone → upstream登録までを終え、練習できる状態にします。

```bash
git clone https://github.com/YOUR_NAME/GitPracticeUnity.git
cd GitPracticeUnity
git remote add upstream https://github.com/misora-kosaka/GitPracticeUnity.git
git remote -v
git status
git log --oneline --graph --decorate --all
```

`origin` は自分のFork、`upstream` は教材本体になるようにしてください。
