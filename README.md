Чтобы запустить сервер необходимо клонировать данный репозиторий, открыть в Visual Studio 
Обратите внимание, для корректной работы серверу необходима запущенная СУБД MySQL, и так же необходимо актуализировать информацию о подключаемой СУБД:
В файле Program.cs изменить версию СУБД MySQL на установленную на вашем компьютере, а также в файле appsettings.json в строке 
"DefaultConnection": "server=localhost;user=root;password=12345678;database=trellodb;" установить актуальный user и password.
После всех настроек в консоле диспечера пакетов выполнить команду Update-Database и запустить программу клавишей F5.