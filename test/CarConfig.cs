using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class CarConfig : IEntityTypeConfiguration<Car>
    {
      public void Configure(EntityTypeBuilder<Car> builder)
    }
}
