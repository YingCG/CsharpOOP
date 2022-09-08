using System;
using System.Collections.Generic;

namespace EventDelegates
{
    public class ClubMember
    {
        private readonly List<string> _members = new List<string>();

        public Action<string> NewMemberAdded;
        public void AddMember(string memberName)
        {
            _members.Add(memberName);

            NewMemberAdded?.Invoke(memberName);
        }
    }

    public class MemberWelcomer
    {
        public void WelcomeMember(string memberName)
        {
            //static allow us to do this --> ClubMember.NewMemberAdded = WelcomeMember;
            Console.WriteLine($"Welcome {memberName}");
        }
    }

    public class Group
    {
        public void AddToGroup(string memberName)
        {
            Console.WriteLine($"Hi {memberName}, you will be assigned to a group soon");
        }
    }
}