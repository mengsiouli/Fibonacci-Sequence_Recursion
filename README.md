# Fibonacci-Sequence_Recursion
## 專案簡介
這是一個 ** C# WinForms 小專案**，用來計算 Fibonacci 數列，練習遞迴 + 記憶化。  

---

## 功能說明 / Logic

- 使用遞迴計算 Fibonacci，搭配記憶化 (memoization) 避免重複計算。
- 邏輯層負責計算與範圍檢查，UI 層負責輸入驗證與顯示。  
- 輸入錯誤或超出範圍會提示錯誤訊息。

---

## 使用說明

1. 在文字框輸入你想計算的項數 (1~30)。
2. 點擊「Calculate」按鈕，會顯示前 n 項的 Fibonacci 數列。

---

## 單元測試 
- **FiboInputChecker**  
  - 驗證字串是否為正整數。
  - 驗證數值是否介於 1~30 之間。
  - 非法輸入應回傳 false。
- **CalculateFibo**  
  - 合法輸入可正確計算 Fibonacci 數值。
  - 輸入超出範圍時應丟出 ArgumentOutOfRangeException。
