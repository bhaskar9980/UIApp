#!/bin/bash
git init
git add .
git commit -m "Initial Commit"
git branch -M main 
git remote add origin ssh://git@bitbucket.trimble.tools/~bhaskar_rongali_trimble.com/uiapp.git
git remote set-url origin --add git@github.com:bhaskar9980/UIApp.git
git remote add bitbucket ssh://git@bitbucket.trimble.tools/~bhaskar_rongali_trimble.com/uiapp.git
git remote add github git@github.com:bhaskar9980/UIApp.git
git push -u origin main