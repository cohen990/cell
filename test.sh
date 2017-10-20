#!/bin/bash

cd cell.tests/
dotnet restore
dotnet watch test
