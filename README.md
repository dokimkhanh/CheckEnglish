# CheckEnglish 📝

**CheckEnglish** — Ứng dụng trắc nghiệm tiếng Anh đơn giản (C# WinForms).

## Mô tả
Ứng dụng cho phép chạy các đề trắc nghiệm nhiều lựa chọn (multiple-choice), chấm điểm nhanh và xem kết quả. Dữ liệu câu hỏi lưu trong SQLite (`Database/database.db`).

## Tính năng
- Chạy đề multiple-choice
- Tính điểm & hiển thị kết quả
- Quản lý câu hỏi qua file DB (SQLite)
- Giao diện Windows (WinForms), dễ dùng cho học sinh/giáo viên

## Yêu cầu
- Windows
- Visual Studio (hoặc .NET/SDK tương ứng) để build từ source
- SQLite DB browser (tùy chọn) để chỉnh sửa `Database/database.db`

## Cài đặt & chạy
1. Clone repo:
```bash
git clone https://github.com/dokimkhanh/CheckEnglish.git
cd CheckEnglish
````

2. Chạy bản build sẵn (nếu có): mở `Releases` tải `CheckEnglish.exe` và chạy.
3. Hoặc build từ source:

   * Mở `CheckEnglish.sln` bằng Visual Studio → Build → Run.
4. DB: `Database/database.db`. Nếu muốn thay bằng DB khác, chỉnh đường dẫn trong cấu hình ứng dụng hoặc thay file DB.

## Lưu ý về DB

* Nếu muốn demo nhanh, giữ `Database/database.db` trong repo.
* Nếu DB chứa dữ liệu nhạy cảm, loại bỏ file và cung cấp script tạo/seed DB cung cấp sẵn thay thế.

## Contributing

* Mở issue nếu gặp lỗi hoặc muốn đề xuất tính năng.
* Pull requests welcome — giữ code rõ ràng và mô tả thay đổi.
## License

[MIT](https://choosealicense.com/licenses/mit/)

