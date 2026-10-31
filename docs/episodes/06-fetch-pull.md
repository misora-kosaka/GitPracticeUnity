<img width="1672" height="941" alt="ChatGPT Image 2026年8月11日 22_18_36 (1)" src="https://github.com/user-attachments/assets/33d4b2eb-7cdc-4ba6-b98e-827bf1ed5c9e" />

# 第6回：fetch / pull / pull --rebase

> **remote操作も自分のForkで再現します**
> [GitPracticeUnity](https://github.com/misora-kosaka/GitPracticeUnity) をForkし、同じForkを2つのフォルダへcloneして「自分」と「チームメンバー役」を再現します。

この回はremoteの変化が必要なので、2つのcloneを使うと理解しやすいです。

## Clone A

通常の作業用clone。

## Clone B（チームメンバー役）

同じForkを別フォルダへcloneします。

```bash
cd ..
git clone https://github.com/YOUR_NAME/GitPracticeUnity.git GitPracticeUnity-teammate
```

Clone Bでmainへcommitしてpushします。

Clone Aへ戻り、まず：

```bash
git fetch origin
git log --oneline --graph --decorate --all
```

local `main` は動かず、`origin/main` だけ進むことを確認します。

続いて：

```bash
git pull --ff-only
```

分岐した履歴も試したい場合は、Clone AとBの双方で別commitを作り、`git pull --rebase` と `git pull --no-rebase` の違いを比較します。
