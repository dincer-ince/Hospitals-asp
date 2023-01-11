const Pool = require('pg').Pool
const pool = new Pool({
  user: 'neru',
  host: 'dpg-cevae51gp3jjsh2lvs8g-a.frankfurt-postgres.render.com',
  database: 'us_hospitals',
  password: 'sniNsO5eLUkd7snm3D8hQhpzxnlz04Bj',
  ssl: true,
  port: 5432,
})


const getUsers = (request, response) => {
    pool.query('SELECT * FROM hospitals ORDER BY "FID" ASC', (error, results) => {
      if (error) {
        throw error
      }
      response.status(200).json(results.rows)
    })
  }

  module.exports = {
    getUsers
  }