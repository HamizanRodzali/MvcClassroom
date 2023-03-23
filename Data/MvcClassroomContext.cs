using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcClassroom.Models;

namespace MvcClassroom.Data
{
    public class MvcClassroomContext : DbContext
    {
        public MvcClassroomContext (DbContextOptions<MvcClassroomContext> options)
            : base(options)
        {
        }

        public DbSet<MvcClassroom.Models.Classroom> Classroom { get; set; } = default!;
    }
}
