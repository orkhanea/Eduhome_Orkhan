using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) :base(option)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogTagToBlog> BlogTagToBlogs { get; set; }
        public DbSet<ChooseEduHome> ChooseEduHomes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<CourseTagToCourse> CourseTagToCourses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventTag> EventTags { get; set; }
        public DbSet<EventTagToEvent> EventTagToEvents { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<HomeTeacherService> HomeTeacherServices { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<NoticeBoardLeft> NoticeBoardLefts { get; set; }
        public DbSet<NoticeBoardRight> NoticeBoardRights { get; set; }
        public DbSet<PositionTestimonial> PositionTestimonials { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SiteSocial> SiteSocials { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<SpeakerToEvent> SpeakerToEvents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<TeacherSocial> TeacherSocials { get; set; }
        public DbSet<TeacherSocialToTeacher> TeacherSocialToTeachers { get; set; }
        public DbSet<VideoTour> VideoTours { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
