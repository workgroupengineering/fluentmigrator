#region License
// Copyright (c) 2007-2024, Fluent Migrator Project
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;

namespace FluentMigrator.Runner
{
    [Obsolete]
    public interface IAnnouncer
    {
        void Heading(string message);
        void Say(string message);
        void Emphasize(string message);
        void Sql(string sql);
        void ElapsedTime(TimeSpan timeSpan);
        void Error(string message);
        void Error(Exception exception);

        [Obsolete]
        void Write(string message, bool isNotSql = true);
    }
}
