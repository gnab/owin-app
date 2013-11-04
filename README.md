# OWIN sample application

Sample OWIN application deployable to Heroku.

### Clone

```
git clone https://github.com/gnab/owin-app
```

### Deploying to Heroku

```
heroku create
heroku config:add BUILDPACK_URL=https://github.com/friism/heroku-buildpack-mono/
git push heroku master
```

### Credits

This application is a fork of the sample application from [Running OWIN/Katana apps on Heroku](http://friism.com/running-owin-katana-apps-on-heroku).
