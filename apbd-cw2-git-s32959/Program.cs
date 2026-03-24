using apbd_cw2_git_s32959;

Service service = new Service();

service.AddLaptop("laptop", 50, "exampleCPU", "exampleGPU");
service.AddCamera("camera", 10, "HD", 60);
service.AddVrHeadSet("headset", 30, 120, "22h");
service.AddUser("Example", "1", UserType.Student);
service.AddUser("Example", "2", UserType.Student);
service.AddUser("Example", "3", UserType.Employee);
service.AddUser("Example", "4", UserType.Employee);
service.RentEquipment(1, 1, 10);
service.RentEquipment(1, 2, -5);
service.RentEquipment(1, 3, 5);
service.ReturnEquipment(1);
service.ReturnEquipment(2);
Console.WriteLine();
service.ShowRaport();