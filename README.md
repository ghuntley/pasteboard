# Pasteboard

[![Build Status](https://travis-ci.org/uzxmx/pasteboard.svg?branch=master)](https://travis-ci.org/uzxmx/pasteboard)
![Icon](https://i.imgur.com/rVJVL3U.png)

Your favourite OSX command line clipboard manipulation libraries `pbcopy` and `pbpaste`ported over to Windows.

* pbcopy copies the standard input and places it in the specified pasteboard.
* pbpaste copies the data from the pasteboard and writes it to the standard output.

## Installation

Installation is done via [scoop](https://scoop.sh/):

```
# Make sure you have added scoop-extras bucket.
$ scoop bucket add extras
$ scoop install pasteboard
```

If you don't want to add scoop-extras bucket, you can install through a remote
json file:

```
$ scoop install https://github.com/lukesampson/scoop-extras/blob/master/bucket/pasteboard.json
```

## Usage

To copy your SSH key to the clipboard:

```
$ cd .ssh
$ type id_rsa.pub | pbcopy
```


To write the contents of your clipboard to a file:

```
$ cd C:\tmp
$ pbpaste > output.txt
$ pbpaste --lf > output.txt # Converting CRLF to LF
```

## Changelogs

### v1.2.0

* Add `--lf` option to convert `CRLF` to `LF`
* Support installation by scoop

## With thanks to
* The original repository is [here](https://github.com/ghuntley/pasteboard).
* The icon "<a href="https://thenounproject.com/term/clipboard/28312" target="_blank">Clipboard</a>" designed by <a href="https://thenounproject.com/Ilsur" target="_blank">Ilsur Aptukov</a> from The Noun Project.
