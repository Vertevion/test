﻿global using AutoMapper;
global using FluentValidation;
global using FluentValidation.Results;
global using LinqKit;
global using MediatR;
global using Microsoft.Extensions.DependencyInjection;
global using System;
global using System.Collections.Generic;
global using System.Globalization;
global using System.Linq;
global using System.Reflection;
global using System.Threading;
global using System.Threading.Tasks;
global using test.Application.Behaviours;
global using test.Application.DTOs.Email;
global using test.Application.Exceptions;
global using test.Application.Features.Departments.Queries.GetDepartments;
global using test.Application.Features.Employees.Queries.GetEmployees;
global using test.Application.Features.Positions.Commands.CreatePosition;
global using test.Application.Features.Positions.Commands.UpdatePosition;
global using test.Application.Features.Positions.Queries.GetPositions;
global using test.Application.Features.SalaryRanges.Queries.GetSalaryRanges;
global using test.Application.Helpers;
global using test.Application.Interfaces;
global using test.Application.Interfaces.Repositories;
global using test.Application.Parameters;
global using test.Application.Wrappers;
global using test.Domain.Entities;
global using test.Domain.Enums;
