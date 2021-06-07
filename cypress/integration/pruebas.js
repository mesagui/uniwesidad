const URL_BASE = 'https://localhost:44341'

describe('Home Carga Correctamente', () => {

    it('Home Cargo', () => {
      //expect(true).to.equal(false)
      cy.request({
          method:'GET',
          url: URL_BASE
      }).then((resp) =>{
          expect(resp.status).to.equal(200);
      })
    })

  })

describe('Login Correcto', () => {

    it('Se logueo', () => {
      //expect(true).to.equal(false)
      cy.request({
          method:'GET',
          url: URL_BASE + '/auth/login',
          form: true,
          body: {
              username: 'admin',
              password: 'admin'
          },
          failOnStatusCode: false,
      }).then((resp) =>{
          expect(resp.status).to.equal(200);
          //expect(resp.redirects[0].split(': ')[1]).to.equal(URL_BASE + '/');
      })
    })
})


describe('Login Incorrecto', () => {

    it('NO se logueo', () => {
          //expect(true).to.equal(false)
        cy.request({
        method:'POST',
        url: URL_BASE + '/auth/login',
        form: true,
        body: {
            username: 'admin',
            password: 'admin1'
        },
        failOnStatusCode: false,
        }).then((resp) =>{
            expect(resp.status).to.equal(400);
        })
    })
})


describe('Registro Curso Correcto', () => {

    it('Se registro curso', () => {
          //expect(true).to.equal(false)
        cy.request({
        method:'POST',
        url: URL_BASE + '/curso/crearcursointerface',
        form: true,
        body: {
            curso: 'Calculo',
            categoria: 2
        },
        failOnStatusCode: false,
        }).then((resp) =>{
            expect(resp.status).to.equal(200);
        })
    })
})


describe('Registro Curso Incorrecto', () => {

    it('No se registro curso', () => {
          //expect(true).to.equal(false)
        cy.request({
        method:'POST',
        url: URL_BASE + '/curso/crearcursointerface',
        form: true,
        body: {
            curso: '',
            categoria: 3

        },
        failOnStatusCode: false,
        }).then((resp) =>{
            expect(resp.status).to.equal(200);
        })
    })
})


