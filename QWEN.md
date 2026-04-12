## Qwen Added Memories
- N_TX_SQL is a Windows Forms application (namespace: KIEMSOAT_RAVAO) for data analysis and prediction with SQL Server integration. Key features:

**Main Components:**
- 3 GridControls: gridControl3, gridControl5, gridControl7 (with DevExpress GridView)
- Multiple TableLayoutPanels (tableLayoutPanel1, tableLayoutPanel2, tableLayoutPanel3, tableLayoutPanel4)
- SplitContainers for layout management
- Number buttons (btn3-btn18) for input
- ComboBox controls: comboBoxEdit1 (selects stored procedure variant 0-21), cbosodongloc, cborow, comboBox_sodongkq, comboBox1
- RichTextBox controls: richTextBox2, richTextBox3, richTextBox4
- TextEdit controls: txtInput, txtSS, txtID, txtPath, txtPase1
- CheckEdits: ckxoa, ck_so, ck_sodong, ckdudoan, checkEdit1

**Key Methods:**
- get_sid() / get_moi() / get_thongtin() - Data loading functions
- loadData() - Calls different stored procedures (LOAD_DATA_18_0 through LOAD_DATA_18_21) based on comboBoxEdit1 selection
- FindBestFilterString() - Filter optimization for grid data
- PerformOptimizedGridFiltering() - Applies filtering to grid
- InsertIntoDatabase() / InsertIntoDatabase_VITRI() - SQL insert operations
- ImportExcelToSQL() - Excel to SQL import using ClosedXML
- ExportDataTableToExcel() - Export data to Excel
- BalanceTableLayoutPanel() - UI layout balancing

**Stored Procedures Used:**
- LOAD_DATA_18_0 through LOAD_DATA_18_21 (various data loading procedures)
- PREDICT_LOAD_DATA_6_2TX_4SO_DUONGDI (prediction)
- ins_datatab123, ins_gom (data insertion)

**Database:** SQL Server via connection string "cn" in ConfigurationManager

**UI Libraries:** DevExpress (grids, buttons, docking), ClosedXML (Excel)

## Rules
- **LUÔN LUÔN TỰ BUILD LAI PROJECT SAU KHI THAY ĐỔI CODE**
  - File solution: `KIEMSOAT_RAVAO.sln`
  - File project: `KIEMSOAT_RAVAO.csproj`
  - Sử dụng MSBuild hoặc build từ Visual Studio
  - Nếu không tìm thấy MSBuild trong PATH, thông báo cho user biết

## Customizations (N_TX_SQL)
- Mặc định: `comboBoxEdit1 = "21"` (load LOAD_DATA_18_21)
- Mặc định: `cbosodongloc = "15"` (giới hạn 15 nếu không có dòng nào)
- `labelControl3` hiển thị số ký tự đã lọc
- `gridColumn27` (SS8): Hiện khi `labelControl3` tăng đúng 1, ẩn khi tăng 2-3 hoặc giảm
- Biến `previousLabelCount3` lưu giá trị trước đó của `labelControl3` để so sánh
