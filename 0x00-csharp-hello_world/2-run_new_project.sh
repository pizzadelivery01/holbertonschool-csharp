#!/usr/bin/env bash

dotnet new console --output 2-new_project
dotnet build 2-new_project
dotnet run -p ./2-new_project