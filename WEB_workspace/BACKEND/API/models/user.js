var mongoose = require('mongoose');
var userSchema = new mongoose.Schema({
 nome: {
 unique: true,
 type: String
 },
 senha: {
 type: String
 },
},
 {
 versionKey: false
 }
);
module.exports = mongoose.model('User', userSchema)