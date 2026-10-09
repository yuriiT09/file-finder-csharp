# File Finder

A C# command-line utility for searching a directory and its subfolders. Search by filename or find files containing a piece of text.

## Run locally

Install the .NET 9 SDK, then run:

```bash
dotnet run --project src/FileFinder/FileFinder/FileFinder.csproj
```

Select filename search or text search and enter an existing folder path. Matches are printed using their full paths.

## Details

- Searches subdirectories recursively
- Matches filenames and text without case sensitivity
- Shows the number of matching files
- Skips files it cannot read during text search

## Notes

This utility reads local files only; it does not change them. Very large directories can take time because files are scanned in one pass.
