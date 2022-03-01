const db = require("../models");
const User = db.users;

checkDuplicateUsername = (req, res, next) => {
  User.findOne({
    username: req.body.username
  }).exec((err, user) => {
    if (err) {
      res.status(500).send({ message: err });
      return;
    }

    if (user) {
      res.status(400).send({ message: "Failed! Username already exists!" });
      return;
    }

    next();

  });
};

const verifySignUp = {
  checkDuplicateUsername
};

module.exports = verifySignUp;