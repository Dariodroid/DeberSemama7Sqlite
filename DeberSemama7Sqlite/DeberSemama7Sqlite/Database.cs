using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeberSemama7Sqlite
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
