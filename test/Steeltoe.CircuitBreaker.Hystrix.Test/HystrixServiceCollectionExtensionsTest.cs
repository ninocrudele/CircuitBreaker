﻿//
// Copyright 2017 the original author or authors.
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

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Steeltoe.CircuitBreaker.Hystrix.Test
{
    public class HystrixServiceCollectionExtensionsTest
    {
        private IHystrixCommandGroupKey groupKey = HystrixCommandGroupKeyDefault.AsKey("DummyCommand");
        private IHystrixCommandKey commandKey = HystrixCommandKeyDefault.AsKey("DummyCommand");

        [Fact]
        public void AddHystrixCommand_ThrowsIfServiceContainerNull()
        {
            IServiceCollection services = new ServiceCollection();
            IConfiguration config = new ConfigurationBuilder().Build();
            string stringKey = "DummyCommand";

            var ex = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(null, groupKey, null));
            Assert.Contains(nameof(services), ex.Message);
            var ex2 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand,DummyCommand>(null, groupKey, null));
            Assert.Contains(nameof(services), ex2.Message);
            var ex3 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(null, stringKey, null));
            Assert.Contains(nameof(services), ex3.Message);
            var ex4 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(null, stringKey, null));
            Assert.Contains(nameof(services), ex4.Message);
            var ex5 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(null, groupKey, commandKey, null));
            Assert.Contains(nameof(services), ex5.Message);
            var ex6 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(null, groupKey, commandKey, null));
            Assert.Contains(nameof(services), ex6.Message);
            var ex7 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(null, stringKey, stringKey, null));
            Assert.Contains(nameof(services), ex7.Message);
            var ex8 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(null, stringKey, stringKey, null));
            Assert.Contains(nameof(services), ex8.Message);
        }

        [Fact]
        public void AddHystrixCommand_ThrowsIfGroupKeyNull()
        {
            IServiceCollection services = new ServiceCollection();
            IConfiguration config = new ConfigurationBuilder().Build();
            string stringKey = "DummyCommand";

            var ex = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, (IHystrixCommandGroupKey)null, null));
            Assert.Contains(nameof(groupKey), ex.Message);
            var ex2 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, (IHystrixCommandGroupKey)null, null));
            Assert.Contains(nameof(groupKey), ex2.Message);
            var ex3 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, (string)null, null));
            Assert.Contains(nameof(groupKey), ex3.Message);
            var ex4 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, (string)null, null));
            Assert.Contains(nameof(groupKey), ex4.Message);
            var ex5 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, null, commandKey, null));
            Assert.Contains(nameof(groupKey), ex5.Message);
            var ex6 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, null, commandKey, null));
            Assert.Contains(nameof(groupKey), ex6.Message);
            var ex7 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services,(string) null, stringKey, null));
            Assert.Contains(nameof(groupKey), ex7.Message);
            var ex8 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, (string) null, stringKey, null));
            Assert.Contains(nameof(groupKey), ex8.Message);
        }

        [Fact]
        public void AddHystrixCommand_ThrowsIfConfigNull()
        {
            IServiceCollection services = new ServiceCollection();
            IConfiguration config = new ConfigurationBuilder().Build();
            string stringKey = "DummyCommand";

            var ex = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, groupKey, null));
            Assert.Contains(nameof(config), ex.Message);
            var ex2 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, groupKey, null));
            Assert.Contains(nameof(config), ex2.Message);
            var ex3 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, stringKey, null));
            Assert.Contains(nameof(config), ex3.Message);
            var ex4 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, stringKey, null));
            Assert.Contains(nameof(config), ex4.Message);
            var ex5 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, groupKey, commandKey, null));
            Assert.Contains(nameof(config), ex5.Message);
            var ex6 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, groupKey, commandKey, null));
            Assert.Contains(nameof(config), ex6.Message);
            var ex7 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, stringKey, stringKey, null));
            Assert.Contains(nameof(config), ex7.Message);
            var ex8 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, stringKey, stringKey, null));
            Assert.Contains(nameof(config), ex8.Message);
        }

        [Fact]
        public void AddHystrixCommand_ThrowsIfCommandKeyNull()
        {
            IServiceCollection services = new ServiceCollection();
            IConfiguration config = new ConfigurationBuilder().Build();
            string stringKey = "DummyCommand";

            var ex5 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, groupKey, null, null));
            Assert.Contains(nameof(commandKey), ex5.Message);
            var ex6 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, groupKey, null, null));
            Assert.Contains(nameof(commandKey), ex6.Message);
            var ex7 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, stringKey, null, null));
            Assert.Contains(nameof(commandKey), ex7.Message);
            var ex8 = Assert.Throws<ArgumentNullException>(() => HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, stringKey, null, null));
            Assert.Contains(nameof(commandKey), ex8.Message);
        }

        [Fact]
        public void AddHystrixCommand_AddsToContainer()
        {
            IServiceCollection services = new ServiceCollection();
            IConfiguration config = new ConfigurationBuilder().Build();
            HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, groupKey, config);
            var provider = services.BuildServiceProvider();
            var command = provider.GetService<DummyCommand>();
            Assert.NotNull(command);
            Assert.Equal(groupKey, command.CommandGroup);
            var expectedCommandKey = HystrixCommandKeyDefault.AsKey(typeof(DummyCommand).Name);
            Assert.Equal(expectedCommandKey, command.CommandKey);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);

            services = new ServiceCollection();
            config = new ConfigurationBuilder().Build();
            HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand,DummyCommand>(services, groupKey, config);
            provider = services.BuildServiceProvider();
            var icommand = provider.GetService<IDummyCommand>();
            Assert.NotNull(icommand);
            command = icommand as DummyCommand;
            Assert.NotNull(command);
            Assert.Equal(groupKey, command.CommandGroup);
            Assert.Equal(expectedCommandKey, command.CommandKey);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);

            HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, "GroupKey", config);
            provider = services.BuildServiceProvider();
            command = provider.GetService<DummyCommand>();
            Assert.NotNull(command);
            Assert.Equal("GroupKey", command.CommandGroup.Name);
            expectedCommandKey = HystrixCommandKeyDefault.AsKey(typeof(DummyCommand).Name);
            Assert.Equal(expectedCommandKey, command.CommandKey);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);

            services = new ServiceCollection();
            config = new ConfigurationBuilder().Build();
            HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, "GroupKey", config);
            provider = services.BuildServiceProvider();
            icommand = provider.GetService<IDummyCommand>();
            Assert.NotNull(icommand);
            command = icommand as DummyCommand;
            Assert.NotNull(command);
            Assert.Equal("GroupKey", command.CommandGroup.Name);
            Assert.Equal(expectedCommandKey, command.CommandKey);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);

            services = new ServiceCollection();
            config = new ConfigurationBuilder().Build();
            HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, groupKey, commandKey, config);
            provider = services.BuildServiceProvider();
            command = provider.GetService<DummyCommand>();
            Assert.NotNull(command);
            Assert.Equal(groupKey, command.CommandGroup);
            Assert.Equal(commandKey, command.CommandKey);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);

            services = new ServiceCollection();
            config = new ConfigurationBuilder().Build();
            HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, groupKey, commandKey, config);
            provider = services.BuildServiceProvider();
            icommand = provider.GetService<IDummyCommand>();
            Assert.NotNull(icommand);
            command = icommand as DummyCommand;
            Assert.NotNull(command);
            Assert.Equal(groupKey, command.CommandGroup);
            Assert.Equal(commandKey, command.CommandKey);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);

            HystrixServiceCollectionExtensions.AddHystrixCommand<DummyCommand>(services, "GroupKey", "CommandKey", config);
            provider = services.BuildServiceProvider();
            command = provider.GetService<DummyCommand>();
            Assert.NotNull(command);
            Assert.Equal("GroupKey", command.CommandGroup.Name);
            Assert.Equal("CommandKey", command.CommandKey.Name);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);

            services = new ServiceCollection();
            config = new ConfigurationBuilder().Build();
            HystrixServiceCollectionExtensions.AddHystrixCommand<IDummyCommand, DummyCommand>(services, "GroupKey", "CommandKey", config);
            provider = services.BuildServiceProvider();
            icommand = provider.GetService<IDummyCommand>();
            Assert.NotNull(icommand);
            command = icommand as DummyCommand;
            Assert.NotNull(command);
            Assert.Equal("GroupKey", command.CommandGroup.Name);
            Assert.Equal("CommandKey", command.CommandKey.Name);
            Assert.NotNull(command.Options);
            Assert.NotNull(command.Options.dynamic);


        }

    }

    interface IDummyCommand
    {

    }
    class DummyCommand: HystrixCommand, IDummyCommand
    {
        IHystrixCommandOptions _opts;
        public DummyCommand(IHystrixCommandOptions opts) : base(opts)
        {
            _opts = opts;
        }

        public HystrixCommandOptions Options
        {
            get
            {
                return _opts as HystrixCommandOptions;
            }
        }
    }
}
