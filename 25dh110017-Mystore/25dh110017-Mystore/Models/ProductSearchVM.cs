using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _25dh110017_Mystore.Models.ViewModel
{
    public class ProductSearchVM
    {
        // Tiêu chí tìm kiếm theo từ khóa (tên, mô tả, danh mục)
        public string SearchTerm { get; set; }

        // Tiêu chí tìm kiếm theo khoảng giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        // Thứ tự sắp xếp
        public string SortOrder { get; set; }

        // Danh sách sản phẩm kết quả sau khi tìm kiếm/sắp xếp
        public List<Product> Products { get; set; }
    }
}