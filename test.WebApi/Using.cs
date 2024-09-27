﻿global using Asp.Versioning;
global using MediatR;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.OpenApi.Models;
global using Serilog;
global using System;
global using System.Collections.Generic;
global using System.Diagnostics;
global using System.Net;
global using System.Text.Json;
global using System.Threading.Tasks;
global using test.Application;
global using test.Application.Exceptions;
global using test.Application.Features.Departments.Queries.GetDepartments;
global using test.Application.Features.Employees.Queries.GetEmployees;
global using test.Application.Features.Positions.Commands.CreatePosition;
global using test.Application.Features.Positions.Commands.DeletePositionById;
global using test.Application.Features.Positions.Commands.UpdatePosition;
global using test.Application.Features.Positions.Queries.GetPositionById;
global using test.Application.Features.Positions.Queries.GetPositions;
global using test.Application.Features.SalaryRanges.Queries.GetSalaryRanges;
global using test.Application.Wrappers;
global using test.Infrastructure.Persistence;
global using test.Infrastructure.Persistence.Contexts;
global using test.Infrastructure.Persistence.SeedData;
global using test.Infrastructure.Shared;
global using test.WebApi.Extensions;
global using test.WebApi.Middlewares;
