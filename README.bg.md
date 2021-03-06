# NRA Database Export

### ���������

���� ������ ���� �� ������� ������������ �� [������� �-18](https://lex.bg/laws/ldoc/2135540645) �� ��������� �� ��������� �� � ��������.

��������� ������� ����� ����������� �� ������� ���������� �������� ��������� � ���� �� ���������� �������� ��� �� ���������� �� ���������
�� ����������� ����� �� ������ �����.

������� ����� �� ��.52�, ��.2, �.3 �����:

> 3. (���. - ��, ��. 26 �� 2019 �., � ���� �� 29.03.2019 �.) �� ��������, ����� �� ���������� � ����� �� �������, �� ����������: �����
> �������� �� �������� � ������ ����� (��), �������� � ������������ �� ����������, ���. ������� � ���������������� ��, ������ ����� ���,
> �������� �� �������� � ���������, ����� � �������� ���� � source-�����, �� ����� � ��������� ����������� ����, �� ������ � ��������� ��
> ����� �� �� � ������������ ����� ��� � ���������� �� ����� - �� ������ ��� �� ���� �� ���������, � ����� ������ ���������, ������
> ������������, ��������� �� � �������������� �� ���������� ���� �������, ������������ ����� ����� �� ������� �� ��������� (��) 2016/679 ��
> ����������� ��������� � �� ������ �� 27 ����� 2016 (��, L119 �� 4 ��� 2016 �.) ��� ������� ���������� �� ������� �� ��. 27 �� ������ ��
> ��������, ��� �������� ���� ����� �� �� ��������;

### �������� ����������

�� �������� ������ � ������������, �������� �������� ���������� ������ �� ����� ���������:

- Microsoft Windows 7+ (64-bit)
- .NET Core 3.1+

### ���������� ���� �����

- SQLite
- MySQL/MariaDB
- Microsoft SQL Server
- Microsoft Access
- Firebird Server
- ODBC

### ���������� ������� �������

- CSV - ������� ����, � ����� ����������� �� ��������� ��������� �������� ���������� ���������
- Comma-separated CSV - ������� ����, � ����� ����������� �� ��������� ��� ���� "," (�������)
- Semicolon-separated CSV - ������� ����, � ����� ����������� �� ��������� ��� ���� ";" (����� � �������)
- JSON - ������� ����, ��������� � [RFC 8259](https://tools.ietf.org/html/rfc8259)

### ����������� �� ������

�������������� �� ����� � ������������ "NRA Database Export" ����� ������ �� ������, ����� ������:

1. ����� **����� �����**

   �� ���� ����� �� ����� ���� ���������� �� ������������.

   ��������� ����� **������**, �� �� ����������.

2. ����� **��������� �� ����**

   1. � ���� **��� ����** �� ������� ���� �� ������ ����� (����. "Microsoft SQL Server").

      ���������: �� ������ � ������������ ������ ���� �����, ��. ����� "���������� ���� �����".

   2. � ���������� �� ��������� ��� ����:

     - ��� � ������� ���� �� ������ ���:

       1. � ���� **����** �� ������� ����������� ����.

     - �����:

       1. � ���� **���� �����** �� ������ ����������� ���� �����;
       2. � ���� **����** �� ������� ����� �� ������;

          ���������: ��� ������ �� � ���������, �� �������� ������ �� ������������.

       2. � ���� **����������** �� ������� ��������������� ��� �� ����;
       3. � ���� **������** �� ������� �������� �� ����;

   3. ��������� ����� **������**, �� �� ����������, ��� **�����** �� ������� ��� ��������� �����.

3. ����� **����� �� ���� �����**

   1. � ���������� �� ��������� ��� ���� �����:

      - ��� � ������� ����, ����� �� �������� ��������� ���� �����, �������� ������ ������ ���� �� �� ������� ��� ��������� �����.
      - �����, �� ������� **���� �����** �� ������ (�������) ������ �����, �� ����� �� ����� ������������ �����.

   2. ��������� ����� **������**, �� �� ����������, ��� **�����** �� ������� ��� ��������� �����.

4. ����� **����� �� �������**

   1. � ������� **�������** �� �������� ���� ��� ������ �������, �� ����� �� ����� ������������ �����.

   2. ��������� ����� **������**, �� �� ����������, ��� **�����** �� ������� ��� ��������� �����.

5. ����� **��������� �� �������**

   1. � ���� **��� �������** �� ������� ��������, � ����� �� ����� �������������� �����

      ���������: �� ������ � ������������ ������� �������, ��. ����� "���������� ������� �������".

   2. � ���� **��� �� �������** �� ������� ������� (������������), � ����� �� ����� �������� ��������� � �������������� �����.

   3. ��������� ����� **������**, �� �� ����������, ��� **�����** �� ������� ��� ��������� �����.

6. ����� **������������**

   1. � ���� **���������** �� �������� ��������� �� ������������ �������, ���� ��������� ������� �������� ������:
   
      - ������ **������������** ������� �������������� �� ��������� (� ������� �����, ��� ��� ������).
      - ������ **������** ������� ���� �� �������������� �� ����������� ��������� ������.
      - ������ **������** ������� ����������� �� �������������� �� ���������, ���� �� ���� �� ����:
        - **Busy**, ��� ������� �� ��������� � ������� �� �����������;
        - **Ok**, ��� ������� �� ��������� �� ������������ �������;
        - **Error**, ��� � ���������� ������ ��� ������������ �� ������� �� ���������.

   2. ��������� ����� **�����������**, �� �� ������������ �������, ��� **�����** �� ������� ��� ��������� �����.

   ���������:

   - �� ����� �� ��������������, ������� � ���� **���������** � ������ ����� �� �������� ����������� �� ��������������.
   - ��� ������� ����������� �� �������������� �� �����, �� ������ �������� ��������, ����� ��������� �� ����.
   - ��� ���������� ������ �� ����� �� �������������� �� �����, �� ������ �������� �������� � ���������� �� ��������.

### ��������������

���� ������ � ����������� �� [NapDatabaseExport](https://github.com/flipm0de/NapDatabaseExport).
