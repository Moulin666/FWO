﻿using Autofac;
using Servers.BackgroundThreads;
using Servers.Config;
using Servers.Handlers;
using Servers.Support;

namespace Servers.Modules
{
	public class ProxyModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder.RegisterType<ClientCodeRemover>().AsImplementedInterfaces();
			builder.RegisterType<ServerType>().AsImplementedInterfaces();
			builder.RegisterType<TestRequestResponseHandler>().AsImplementedInterfaces();
			builder.RegisterType<TestRequestEventHandler>().AsImplementedInterfaces();
			builder.RegisterType<TestBackgroundThread>().AsImplementedInterfaces();
		}
	}
}
