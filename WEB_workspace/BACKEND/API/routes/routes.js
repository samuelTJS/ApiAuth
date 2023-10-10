const express = require('express');
const router = express.Router()
module.exports = router;
const modeloTarefa = require('../models/tarefa');

router.post('/post', verificaJWT, async (req, res) => {
    const objetoTarefa = new modeloTarefa({
    descricao: req.body.descricao,
    statusRealizada: req.body.statusRealizada
    })
    try {
    const tarefaSalva = await objetoTarefa.save();
    res.status(200).json(tarefaSalva)
    }
    catch (error) {
    res.status(400).json({ message: error.message })
    }
   })

   router.get('/getAll', verificaJWT, async (req, res) => {
    try {
    const resultados = await modeloTarefa.find();
    res.json(resultados)
    }
    catch (error) {
    res.status(500).json({ message: error.message })
    }
   })

   router.delete('/delete/:id', verificaJWT, async (req, res) => {
    try {
    const resultado = await modeloTarefa.findByIdAndDelete(req.params.id)
    res.json(resultado)
    }
    catch (error) {
    res.status(400).json({ message: error.message })
    }
   })

   router.patch('/update/:id', verificaJWT, async (req, res) => {
    try {
    const id = req.params.id;
    const novaTarefa = req.body;
    const options = { new: true };
    const result = await modeloTarefa.findByIdAndUpdate(
    id, novaTarefa, options
    )
    res.json(result)
    }
    catch (error) {
    res.status(400).json({ message: error.message })
    }
   })

   router.get('/obterTarefasContendo/:substring', verificaJWT, async (req, res) => {
    try {
      const resultados = await modeloTarefa.find({ descricao: { $regex: req.params.substring, $options: "i" } });
      res.json(resultados);
    } catch (error) {
      res.status(500).json({ message: error.message });
    }
  });
   
   //Autorizacao
function verificaUsuarioSenha(req, res, next) {
  if (req.body.nome !== 'branqs' || req.body.senha !== '1234') {
  return res.status(401).json({ auth: false, message: 'Usuario ou Senha incorreta' });
  }
  next();
 }
 

//Nova forma de Autorizacao
function verificaJWT(req, res, next) {
  const token = req.headers['id-token'];
  if (!token) return res.status(401).json({
  auth: false, message: 'Token nao fornecido'
  });
  jwt.verify(token,'segredo', function (err, decoded) {
  if (err) return res.status(500).json({ auth: false, message: 'Falha !' });
  next();
  });
 }
 
//Segunda forma de Autenticacao - Busca usuário no BD e compara senha
const userModel = require('../models/user');
var jwt = require('jsonwebtoken');
router.post('/login', async (req, res) => {
 try {
 const data = await userModel.findOne({ 'nome': req.body.nome });

 if (data != null && data.senha === req.body.senha) {
 const token = jwt.sign({ id: req.body.user }, 'segredo',
 { expiresIn: 300 });
 return res.json({ token: token });
 }

 res.status(500).json({ message: 'Login invalido!' });
 } catch (error) {
 res.status(500).json({ message: error.message })
 }
})
