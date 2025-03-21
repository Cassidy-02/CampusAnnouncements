using CampusAnnouncements.Models;

namespace CampusAnnouncements.Services
{
    public class AnnouncementService
    {
        private readonly List<Announcement> _announcements;

        public AnnouncementService()
        {
            _announcements = new List<Announcement>
            {
                new Announcement { Id = 1, Title = "Welcome Week", Content = "Join us for a week of fun activities!", Date = DateTime.Now.AddDays(-1) },
                new Announcement { Id = 2, Title = "Guest Lecture", Content = "Don't miss the guest lecture by Dr. Smith on AI.", Date = DateTime.Now }
            };
        }

        public List<Announcement> GetAnnouncements()
        {
            return _announcements.OrderByDescending(a => a.Date).ToList();
        }

        public void AddAnnouncement(Announcement announcement)
        {
            announcement.Id = _announcements.Max(a => a.Id) + 1;
            _announcements.Add(announcement);
        }
    }
}
