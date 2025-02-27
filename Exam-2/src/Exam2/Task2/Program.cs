using Task2;

Membership membership = new Membership();

Member member1 = membership.SetMembershipStatus("Iqbal", AccountStatus.Active);
Member member2 = membership.SetMembershipStatus("Hassan", AccountStatus.Blocked);
Member member3 = membership.SetMembershipStatus("Mahmud", AccountStatus.InActive);

Console.WriteLine(member1);
Console.WriteLine(member2);
Console.WriteLine(member3);