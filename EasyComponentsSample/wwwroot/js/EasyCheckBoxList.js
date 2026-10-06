
class CheckDropDown {

    constructor(container) {

        this.container = container;
        this.content = container.querySelector('[data-easycblist="container"]'); 
        this.panel = container.querySelector('[data-easycblist="panel"]');
        this.placeholder = this.content?.dataset.placholder || '';

        this.BindEvents();
        this.Refresh();
    }

    BindEvents() {

        this.container.addEventListener('change', (e) => {
 //alert();
            if (e.target.matches('input[type="checkbox"]')) {
                this.Refresh();
            }
        });

        const header =
            this.content ||
            this.container.querySelector('[onclick*="FDropCheck"]');

        if (header) {
            header.addEventListener('click', (e) => {
               
                e.stopPropagation();
                this.Toggle();
            });
        }
    }

    Toggle() {

        if (!this.panel)
            return;

        const visible = getComputedStyle(this.panel).display !== 'none';
        this.panel.style.display = visible ? 'none' : '';
    }

     open() {
         alert("open");
         if (this.panel)
             this.panel.style.display = '';
     }

     close() {
  
         if (this.panel)
             this.panel.style.display = 'none';
     }

    Refresh() {

        if (!this.content)
            return;

        const checkedItems = this.GetCheckedItems();

        if (checkedItems.length === 0) {

            this.content.innerHTML = this.placeholder;
            return;
        }

        const fragment = document.createDocumentFragment();

        checkedItems.forEach(item => {
            fragment.appendChild(
                this.CreateButton(item.id, item.text)
            );
        });

        this.content.innerHTML = '';
        this.content.appendChild(fragment);

        // const totalWidth =
        //     [...this.content.querySelectorAll('[data-checkid]')]
        //         .reduce((sum, btn) => sum + btn.offsetWidth, 0);

        // if (totalWidth > this.content.clientWidth) {

        //     this.content.innerHTML =
        //         `${this.placeholder} selected: ${checkedItems.length}`;
        // }
    }

    GetCheckedItems() {
        return [...this.container.querySelectorAll('input[type="checkbox"]:checked')]
            .map(chk => {

                const label =
                    this.container.querySelector(`label[for="${chk.id}"]`) ||
                    document.querySelector(`label[for="${chk.id}"]`);

                return {
                    id: chk.id,
                    text: label?.textContent?.trim() || ''
                };
            });
    }

    CreateButton(id, text) {
        const btn = document.createElement('button');
        btn.type = 'button';
        btn.dataset.checkid = id;
        btn.innerHTML = `${text}`;

        btn.addEventListener('click', (e) => {

            e.stopPropagation();
            const chk = document.getElementById(id);

            if (chk) {
                chk.checked = false;
            }

            this.Refresh();

            if (typeof Summ === 'function') {
                Summ();
            }
        });

        return btn;
    }
}

document.addEventListener('DOMContentLoaded', () => {

    const dropdowns =
        [...document.querySelectorAll('[data-easycblist="start"]')]
            .map(container => new CheckDropDown(container));

    window.addEventListener('click', (event) => {
        const active = event.target.closest('[data-easycblist="start"]');
        dropdowns.forEach(dropdown => {

            if (dropdown.container !== active) {
                dropdown.close();
            }
        });
    });

//     window.CheckPostovi = function () {
// alert("ww")
//         dropdowns.forEach(x => x.Refresh());
//     };
});
