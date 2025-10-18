const sidebarBtns = document.querySelectorAll('.sidebar-btn');

sidebarBtns.forEach(btn => {
    btn.addEventListener('click', () => {
        const submenu = btn.nextElementSibling; // ul.submenu
        const icon = btn.querySelector('i');   // icon mũi tên

        // Toggle hiển thị submenu
        if (submenu.style.display === 'block') {
            submenu.style.display = 'none';
            icon.style.transform = 'rotate(0deg)'; // icon quay về ban đầu
        } else {
            submenu.style.display = 'block';
            icon.style.transform = 'rotate(180deg)'; // icon xoay xuống
        }
    });
});