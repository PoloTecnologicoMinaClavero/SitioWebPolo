const UrlApiHome ="/api/Home"
const counters = new Vue({
    el: "#ContadoresJs",
    data: {
        CandtidadTrabajando: 1,
        CandtidadProyectos: 1,
        CandtidadCursosDictados: 1,
        DiasExistenciaPolo: 1
    },
    methods: {
        GetCounters: function () {
            axios.get(UrlApiHome + "/GetCounters").then((response) => {
                if (response && response.data) {
                    var x = response.data;
                    console.log(x);
                    this.CandtidadTrabajando = x.CandtidadTrabajando;
                    this.CandtidadProyectos = x.CandtidadProyectos;
                    this.CandtidadCursosDictados = x.CandtidadCursosDictados;
                    this.DiasExistenciaPolo = x.DiasExistenciaPolo;
                }
            });
        }
    },
    mounted: function () {
        this.GetCounters();
    }
});
