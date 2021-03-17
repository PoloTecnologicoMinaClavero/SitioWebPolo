const url = "/api/Contacto";

class ContactoRequest {
    constructor(data) {
        this.NombreApellido = data?.NombreApellido;
        this.Email = data?.Email;
        this.Asunto = data?.Asunto;
        this.Mensaje = data?.Mensaje;
    }
    GetJson() {
        return JSON.stringify(this);
    }
    static CleanPropeties(data) {
        for (const key in new ContactoRequest({}))
            data[key] = "";
    }
}

const vm = new Vue({
    el: "#ContactoJs",
    data: {
        NombreApellido: "",
        Email: "",
        Asunto: "",
        Mensaje: "",

        p_ErrorMessage: "",
        p_SuccessMessage: "",
        p_DisabledForm: false,
    },
    methods: {
        SendMail: async function () {
            const contacto = new ContactoRequest(vm.$data);

            this.p_DisabledForm = true;
            this.p_ErrorMessage = "";
            this.p_SuccessMessage = "";

            axios.post(url + "/SendMailAsync", contacto)
                .then(() => {
                    this.p_SuccessMessage = "Su mensaje ha sido enviado!";
                    ContactoRequest.CleanPropeties(vm.$data);
                })
                .catch(error => {

                    console.error(error);
                    this.p_ErrorMessage = error.message;

                }).then(() => {
                    this.p_DisabledForm = false;
                });
        }
    }
});