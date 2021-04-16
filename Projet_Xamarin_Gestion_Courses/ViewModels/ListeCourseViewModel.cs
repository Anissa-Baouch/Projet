using Projet_Xamarin_Gestion_Courses.Models;
using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;


namespace Projet_Xamarin_Gestion_Courses.ViewModels
{
    class ListeCourseViewModel : BindableObject
    {
        private List<Course> _courses;

        public List<Course> Courses { get => _courses; set { _courses = value; OnPropertyChanged(); } }

        public ListeCourseViewModel()
        {
        if (Courses == null)
            Courses = new List<Course>();
        Courses = App.ListCourse;
        }
     
    }
}
