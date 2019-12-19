#!/bin/bash
cd "$(dirname "$0")"

reveal-md ../presentation/presentation.md --print ../out/presentation.pdf
