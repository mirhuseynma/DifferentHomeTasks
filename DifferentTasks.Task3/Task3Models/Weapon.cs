using DifferentTasks.Task3.Enums;
using DifferentTasks.Task3.Errors;

namespace DifferentTasks.Task3.Task3Models
{
    public class Weapon
    {
        private static int _ID;

        public Weapon( string name, int currentBulletInMagazine, FireMode modeForFire)
        {
            _ID++;
            Id = _ID;
            Name = name;
            Description = "Odlu Silah";
            CapacityMagazine = 40;
            CurrentBulletInMagazine = currentBulletInMagazine;
            if (CurrentBulletInMagazine > CapacityMagazine) throw new CanNotGreater($"Maqazinin tutumu {CapacityMagazine} gulledir. Bundan artigini yerlesdire bilmessiniz");
            TimeFullUnloadMagazine = 15;
            ModeForFire = modeForFire;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get;}
        public int CapacityMagazine { get; set; }
        public int CurrentBulletInMagazine{ get; set; }
        public double TimeFullUnloadMagazine{ get; set; }
        public FireMode ModeForFire { get; set; }

        public void Shoot()
        {
            
            CurrentBulletInMagazine--;
            if (CurrentBulletInMagazine < 0)
                throw new CanNotLessZero("Daraqda gulle sayi bitmisdir yeniden doldurun!!");
            else Console.WriteLine($"Daraqdaki gulle sayi: {CurrentBulletInMagazine}\n");
        }

        public void Fire()
        {   
            if (ModeForFire != FireMode.Automatic) ModeForFire = FireMode.Automatic;
            Console.WriteLine($"Silah avtomat rejime kecirilib atisa baslanmisdir\n");
            TimeSpan time = TimeSpan.FromSeconds(TimeFullUnloadMagazine);
            Thread.Sleep(time);
            for (int i = CurrentBulletInMagazine; i > 0; i--)
            {
                CurrentBulletInMagazine--;
                if (CurrentBulletInMagazine == 0) Console.WriteLine($"Daraqda gulle sayi {TimeFullUnloadMagazine} saniyede sifirlanmisdir. Daragi yeniden doldurun!!\n");
            }
        }

        public void GetRemainBullet()
        {
            Console.WriteLine($"Daraqdaki gulle sayi: {CurrentBulletInMagazine}\nDaragin tam dolmasi uchun {CapacityMagazine - CurrentBulletInMagazine} gulle elave etmelisiniz!!");
        }

        public void ChangeFireMode()
        {
            if(ModeForFire == FireMode.Automatic)
            {
                ModeForFire = FireMode.Single;
                Console.WriteLine($"Atish modu {ModeForFire} tipine kecirildi");
            }
            else
            {
                ModeForFire = FireMode.Automatic;
                Console.WriteLine($"Atish modu {ModeForFire} tipine kecirildi");
            }
        }

        public void Reload()
        {
            CurrentBulletInMagazine = CapacityMagazine;
            Console.WriteLine($"Daraq yeniden doldurulmusdur. Daraqdaki gulle sayi: {CurrentBulletInMagazine}\n");
        }

        public void GetAllMethods()
        {
            while (true)
            {
                Console.WriteLine("Emeliyyati sechin:\n0 - Informasiya\n1 - Shoot metodu\n2 - Fire metodu\n3 - Daragin dolmasi ucun lazim olan gulle sayi\n4 - Reload\n5 - Atish modu\n6 - Programi bitir\n7 - Redakte et");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        Console.WriteLine($"ID: {Id}\nName: {Name}\nDescription: {Description}\nCapacityMagazine: {CapacityMagazine}\nCurrentBulletInMagazine: {CurrentBulletInMagazine}\nTimeFullUnloadMagazine: {TimeFullUnloadMagazine}\nModeForFire: {ModeForFire}");
                        break;
                    case 1:
                        Shoot();
                        break;
                    case 2:
                        Fire();
                        break;
                    case 3:
                        GetRemainBullet();
                        break;
                    case 4:
                        Reload();
                        break;
                    case 5:
                        ChangeFireMode();
                        break;
                    case 6:
                        throw new TheEnd("Program bitdi!!");

                    case 7:
                        Console.WriteLine("T - Daragin tutumunu deyis\nS - Gulle sayini deyish\nD - Sifirlama saniyesini deyish");
                        string newChoice = Console.ReadLine();
                        newChoice.ToUpper();
                        if (newChoice == "T")
                        {
                            Console.WriteLine("Yeni tutumu daxil edin:");
                            CapacityMagazine = int.Parse(Console.ReadLine());
                        }
                        if (newChoice == "S")
                        {
                            Console.WriteLine("Maqazinde qalmis gulle sayini daxil edin");
                            CurrentBulletInMagazine = int.Parse(Console.ReadLine());
                            if (CurrentBulletInMagazine > CapacityMagazine) throw new CanNotGreater($"Maqazinin tutumu {CapacityMagazine} gulledir. Bundan artigini yerlesdire bilmessiniz");
                        }
                        if (newChoice != "T" && newChoice != "S" && newChoice != "D")
                        {
                            Console.WriteLine("Emeliyyati sechin:\n0 - Informasiya\n1 - Shoot metodu\n2 - Fire metodu\n3 - Daragin dolmasi ucun lazim olan gulle sayi\n4 - Reload\n5 - Atish modu\n6 - Programi bitir\n7 - Redakte et");
                            choose = int.Parse(Console.ReadLine());
                        }
                        if (newChoice == "D")
                        {
                            Console.WriteLine("Sifirlama saniyesini daxil edin:");
                            TimeFullUnloadMagazine = double.Parse(Console.ReadLine());
                        }
                        else 
                        {
                            Console.WriteLine("T - Daragin tutumunu deyis\nS - Gulle sayini deyish\nD - Sifirlama saniyesini deyish");
                            newChoice = Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
}
