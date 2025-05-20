using System;
using System.IO;

namespace Consolka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Управление дисками и файлами ===");
            
            while (true)
            {
                Console.WriteLine("\nГлавное меню:");
                Console.WriteLine("1. Просмотреть доступные диски");
                Console.WriteLine("2. Работа с конкретным диском");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите действие: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAvailableDrives();
                        break;
                    case "2":
                        WorkWithDrive();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void ShowAvailableDrives()
        {
            Console.WriteLine("\nДоступные диски:");
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"- {drive.Name}");
                Console.WriteLine($"  Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"  Метка тома: {drive.VolumeLabel}");
                    Console.WriteLine($"  Файловая система: {drive.DriveFormat}");
                    Console.WriteLine($"  Доступно места: {BytesToGB(drive.AvailableFreeSpace)} GB из {BytesToGB(drive.TotalSize)} GB");
                }
                else
                {
                    Console.WriteLine("  Диск не готов");
                }
            }
        }

        static void WorkWithDrive()
        {
            Console.Write("\nВведите букву диска (например, C): ");
            string driveLetter = Console.ReadLine().ToUpper() + ":\\";

            try
            {
                DriveInfo drive = new DriveInfo(driveLetter);
                if (!drive.IsReady)
                {
                    Console.WriteLine("Диск не готов или не существует.");
                    return;
                }

                Console.WriteLine($"\nРабота с диском {drive.Name}");
                Console.WriteLine($"Свободно: {BytesToGB(drive.AvailableFreeSpace)} GB");
                Console.WriteLine($"Всего: {BytesToGB(drive.TotalSize)} GB");

                while (true)
                {
                    Console.WriteLine("\nМеню работы с диском:");
                    Console.WriteLine("1. Просмотреть содержимое корневой папки");
                    Console.WriteLine("2. Создать папку");
                    Console.WriteLine("3. Удалить папку");
                    Console.WriteLine("4. Создать файл");
                    Console.WriteLine("5. Удалить файл");
                    Console.WriteLine("6. Вернуться в главное меню");
                    Console.Write("Выберите действие: ");

                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            ShowDirectoryContents(drive.RootDirectory.FullName);
                            break;
                        case "2":
                            CreateDirectory(drive.RootDirectory.FullName);
                            break;
                        case "3":
                            DeleteDirectory(drive.RootDirectory.FullName);
                            break;
                        case "4":
                            CreateFile(drive.RootDirectory.FullName);
                            break;
                        case "5":
                            DeleteFile(drive.RootDirectory.FullName);
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void ShowDirectoryContents(string path)
        {
            try
            {
                Console.WriteLine($"\nСодержимое {path}:");

                // Показываем поддиректории
                string[] directories = Directory.GetDirectories(path);
                Console.WriteLine("\nПапки:");
                foreach (string dir in directories)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    Console.WriteLine($"- {di.Name} (Создана: {di.CreationTime})");
                }

                // Показываем файлы
                string[] files = Directory.GetFiles(path);
                Console.WriteLine("\nФайлы:");
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    Console.WriteLine($"- {fi.Name} (Размер: {BytesToKB(fi.Length)} KB, Создан: {fi.CreationTime})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при просмотре содержимого: {ex.Message}");
            }
        }

        static void CreateDirectory(string rootPath)
        {
            Console.Write("\nВведите имя новой папки: ");
            string dirName = Console.ReadLine();
            string newDirPath = Path.Combine(rootPath, dirName);

            try
            {
                if (Directory.Exists(newDirPath))
                Console.WriteLine("Папка уже существует.");
                else
                {
                    Directory.CreateDirectory(newDirPath);
                    Console.WriteLine("Папка успешно создана.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании папки: {ex.Message}");
            }
        }

        static void DeleteDirectory(string rootPath)
        {
            Console.Write("\nВведите имя папки для удаления: ");
            string dirName = Console.ReadLine();
            string dirPath = Path.Combine(rootPath, dirName);

            try
            {
                if (!Directory.Exists(dirPath))
                    Console.WriteLine("Папка не существует.");
                else
                {
                    Directory.Delete(dirPath);
                    Console.WriteLine("Папка успешно удалена.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении папки: {ex.Message}");
            }
        }

        static void CreateFile(string rootPath)
        {
            Console.Write("\nВведите имя нового файла: ");
            string fileName = Console.ReadLine();
            string filePath = Path.Combine(rootPath, fileName);

            try
            {
                if (File.Exists(filePath))
                    Console.WriteLine("Файл уже существует.");
                else
                {
                    Console.Write("Введите содержимое файла: ");
                    string content = Console.ReadLine();
                    
                    File.WriteAllText(filePath, content);
                    Console.WriteLine("Файл успешно создан.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
            }
        }

        static void DeleteFile(string rootPath)
        {
            Console.Write("\nВведите имя файла для удаления: ");
            string fileName = Console.ReadLine();
            string filePath = Path.Combine(rootPath, fileName);

            try
            {
                if (!File.Exists(filePath))
                    Console.WriteLine("Файл не существует.");
                else
                {
                    File.Delete(filePath);
                    Console.WriteLine("Файл успешно удален.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении файла: {ex.Message}");
            }
        }

        static double BytesToGB(long bytes)
        {
            return Math.Round(bytes / 1024.0 / 1024 / 1024, 2);
        }

        static double BytesToKB(long bytes)
        {
            return Math.Round(bytes / 1024.0, 2);
        }
    }
}